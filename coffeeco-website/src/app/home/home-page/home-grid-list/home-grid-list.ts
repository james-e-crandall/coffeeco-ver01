import { Component, inject, OnInit } from '@angular/core';
import {MatGridListModule} from '@angular/material/grid-list';

import { HomeService } from './home-service';
import { HomeItemDirective } from './home-directive';
import { HomeList } from  './home-list.schema'

@Component({
  selector: 'coffeeco-home-grid-list',
  imports: [MatGridListModule],
  templateUrl: './home-grid-list.html',
  styleUrl: './home-grid-list.css',
})
export class HomeGridList implements OnInit {

  homeService = inject(HomeService);
  homeList: HomeList = { cols: 2 , homeRows: [] };

  protected readonly homeListResource = this.homeService.GetHomeListCurrent();

  ngOnInit(): void {

  }
}
