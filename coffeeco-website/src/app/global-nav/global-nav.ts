import { Component, inject, OnInit, signal } from '@angular/core';
import { BreakpointObserver, Breakpoints, BreakpointState } from '@angular/cdk/layout';

import { Toolbar } from './toolbar/toolbar';
import { ToolbarMenu } from './toolbar-menu/toolbar-menu';

@Component({
  selector: 'coffeeco-global-nav',
  imports: [
    Toolbar,
    ToolbarMenu,
  ],
  templateUrl: './global-nav.html',
  styleUrl: './global-nav.css',
})
export class GlobalNav implements OnInit {
  isMobile = signal(false);
  breakpointObserver = inject(BreakpointObserver);
  layoutChanges = this.breakpointObserver.observe([
    Breakpoints.XSmall,
    Breakpoints.Small,
    Breakpoints.Medium,
    Breakpoints.Large,
    Breakpoints.XLarge,
  ]);

  ngOnInit() {
    this.layoutChanges.subscribe(result => {
      if(result.matches) {
        if(result.breakpoints[Breakpoints.XSmall] || result.breakpoints[Breakpoints.Small]) {
          this.isMobile.set(true);
        } else {
          this.isMobile.set(false);
        }
      }
    });
  }
}
