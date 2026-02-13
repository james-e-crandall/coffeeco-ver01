import { Component, inject, OnInit } from '@angular/core';
import {MatGridListModule} from '@angular/material/grid-list';

import { HomeItemService } from './home-item-service';
import { HomeItemDirective } from './home-item-directive';
import { HomeList } from './home-item';

@Component({
  selector: 'coffeeco-home-item-grid-list',
  imports: [MatGridListModule, HomeItemDirective],
  templateUrl: './home-item-grid-list.html',
  styleUrl: './home-item-grid-list.css',
})
export class HomeItemGridList implements OnInit {

  homeItemService = inject(HomeItemService);
  homeList: HomeList = { cols: 2 };

  ngOnInit(): void {
    this.homeList = this.homeItemService.getHomeList();
  }
}
