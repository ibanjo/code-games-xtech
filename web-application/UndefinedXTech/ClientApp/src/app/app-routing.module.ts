import { LoginComponent } from './features/login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './core/auth.guard';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    canActivate: [AuthGuard],
    component: HomeComponent
  },
  {
    path: 'login',
    loadChildren: () => import('./features/login/login.module').then(m => m.LoginModule)
  },
  {
    path: 'search',
    canActivate: [AuthGuard],
    loadChildren: () => import('./features/search/search.module').then(m => m.SearchModule)
  },
  {
    path: 'skill-form',
    canActivate: [AuthGuard],
    loadChildren: () => import('./features/skill-page/skill-page.module').then(m => m.SkillPageModule)
  },
  {
    path: 'search-result',
    canActivate: [AuthGuard],
    loadChildren: () => import('./features/search-result/search-result.module').then(m => m.SearchResultModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
