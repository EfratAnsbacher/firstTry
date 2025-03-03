import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { GiftsManagementComponent } from './components/gifts-management/gifts-management.component';
import { CategoriesComponent } from './components/categories/categories.component';

@Component({ 
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,CommonModule,GiftsManagementComponent,CategoriesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ChineseAction';
}
