import { Component, signal } from '@angular/core';

@Component({
  selector: 'coffeeco-placeholder-page',
  imports: [],
  templateUrl: './placeholder-page.html',
  styleUrl: './placeholder-page.css',
})
export class PlaceholderPage {
protected readonly title = signal('coffeeco-website');
}
