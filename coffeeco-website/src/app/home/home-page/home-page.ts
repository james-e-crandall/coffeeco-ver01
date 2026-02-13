import { Component } from '@angular/core';
import { HomeItemGridList } from './home-item-grid-list/home-item-grid-list';

@Component({
  selector: 'coffeeco-home-page',
  imports: [HomeItemGridList],
  templateUrl: './home-page.html',
  styleUrl: './home-page.css',
})
export class HomePage {

}
