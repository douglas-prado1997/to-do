import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component'; // Ajuste o caminho conforme necessário
import { TasksComponent } from './tasks/tasks/tasks.component';

export const routes: Routes = [
  { path: '', component: LoginComponent }, 
  { path: 'login', component: LoginComponent },
  { path: 'tasks', component: TasksComponent },

];
