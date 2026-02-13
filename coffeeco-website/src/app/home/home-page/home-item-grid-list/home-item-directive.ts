import { Directive, input } from '@angular/core';
import { HomeItem } from './home-item';

@Directive({
  selector: '[coffeecoHomeItemDirective]'
})
export class HomeItemDirective {
  item = input.required<HomeItem>();

  constructor() { }

}
