import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UpdateShippersFormComponent } from './components/update-shippers-form/update-shippers-form.component';

const routes: Routes = [
  //{ path: 'Create', component: ShippersFormComponent },
  //{ path: 'Update', component: UpdateShippersFormComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
