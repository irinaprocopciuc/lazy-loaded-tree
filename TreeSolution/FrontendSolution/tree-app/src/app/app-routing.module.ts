import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TreeComponent } from './components/tree/tree.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'tree',
    pathMatch: 'full'
  },
  {
    path: 'tree',
    component: TreeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
