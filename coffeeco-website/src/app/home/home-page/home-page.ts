import { Component } from '@angular/core';
import { HomeGridList } from './home-grid-list/home-grid-list';

@Component({
  selector: 'coffeeco-home-page',
  imports: [HomeGridList],
  templateUrl: './home-page.html',
  styleUrl: './home-page.css',
})
export class HomePage {

}
