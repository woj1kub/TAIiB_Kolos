import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KeyboardsComponent } from './keyboards/keyboards.component';
import { MousesComponent } from './mouses/mouses.component';

const routes: Routes = [
  {path: "keyboard", component: KeyboardsComponent},
  {path: "mouse", component: MousesComponent},
  { path: '', redirectTo: '/keyboard', pathMatch: 'full' },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
