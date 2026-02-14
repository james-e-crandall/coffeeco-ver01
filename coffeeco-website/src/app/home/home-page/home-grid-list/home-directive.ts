import { Directive, input } from '@angular/core';
import { HomeItem } from './home-list.schema';

@Directive({
  selector: '[coffeecoHomeItemDirective]'
})
export class HomeItemDirective {
  item = input.required<HomeItem>();

  constructor() { }

}
