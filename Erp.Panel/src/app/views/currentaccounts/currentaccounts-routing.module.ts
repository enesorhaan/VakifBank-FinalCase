import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './list/list.component';
import { AddComponent } from './add/add.component';
import { EditComponent } from './edit/edit.component';

const routes: Routes = [
  {
    path: 'list',
    component: ListComponent,
    data: {
      title: 'Current Account List'
    }
  },
  {
    path: 'add',
    component: AddComponent,
    data: {
      title: 'Add Current Account'
    }
  },
  {
    path: 'edit/:id',
    component: EditComponent,
    data: {
      title: 'Edit Current Account'
    }
  },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CurrentAccountsRoutingModule {
}
