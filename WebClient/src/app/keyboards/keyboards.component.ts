import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { KeyboardDTO } from '../../dto/KeyboardDTO';
import { response } from 'express';
import { KeyboardType } from "../../keyboard-type.enum";


@Component({
  selector: 'app-keyboards',
  templateUrl: './keyboards.component.html',
  styleUrl: './keyboards.component.css'
})
export class KeyboardsComponent implements OnInit {
  keyboardTypes = Object.values(KeyboardType);
  keyboardTypeKeys = Object.keys(KeyboardType);
  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getKeyboards();
  }

  keyboard: any[] = [];
  new: KeyboardDTO = {model: '', rodzaj: 0};
  showForm: boolean = false;

  getKeyboards(): void {
    this.http
    .get<any[]>('https://localhost:7005/api/Keyboard')
    .subscribe((data) => {this.keyboard = data;});
  }
  deleteKeyboard(id: number): void {
    this.http
    .delete(`https://localhost:7005/api/Keyboard/${id}`)
    .subscribe(() => {this.keyboard = this.keyboard.filter((keyboard) => keyboard.id !== id);});
  }
  onSubmit():void {
    this.http
    .post<number>('https://localhost:7005/api/Keyboard', this.new)
    .subscribe({
      next:(response: number) => {
        if(response != -1) {
          this.getKeyboards();
          this.toggle();
        }
      }
    })
  }
  toggle(): void {
    this.showForm = !this.showForm;
  }
}
