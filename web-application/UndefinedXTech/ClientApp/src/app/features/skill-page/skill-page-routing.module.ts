import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { SkillPageComponent } from './skill-page.component';

export const routes: Routes = [
  {
    path: '',
    component: SkillPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SkillPageRoutingModule { }
