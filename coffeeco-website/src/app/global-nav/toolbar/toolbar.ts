import { Component, inject, OnInit } from '@angular/core';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { RouterLink } from '@angular/router';

import { MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'coffeeco-toolbar',
  imports: [MatToolbarModule, MatIconModule, MatButtonModule, RouterLink],
  templateUrl: './toolbar.html',
  styleUrl: './toolbar.css',
})
export class Toolbar implements OnInit {
 matIconRegistry = inject(MatIconRegistry);
  domSanitizer = inject(DomSanitizer);

  ngOnInit(): void {
    this.matIconRegistry.addSvgIcon(
        'my-icon',
        this.domSanitizer.bypassSecurityTrustResourceUrl('assets/icons/coffeeco-icon.svg')
      );
  }

}
