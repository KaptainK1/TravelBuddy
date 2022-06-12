import { Component, OnInit } from '@angular/core';
import { faPlaneDeparture } from '@fortawesome/free-solid-svg-icons';
import { faHouseChimneyWindow } from '@fortawesome/free-solid-svg-icons';
import { faScrewdriverWrench } from '@fortawesome/free-solid-svg-icons';
import { faListCheck } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-header-component',
  templateUrl: './header-component.component.html',
  styleUrls: ['./header-component.component.css']
})
export class HeaderComponent implements OnInit {

  faPlaneDeparture = faPlaneDeparture;
  faHouseChimneyWindow = faHouseChimneyWindow;
  faScrewdriverWrench = faScrewdriverWrench;
  faListCheck = faListCheck;

  constructor() { }

  ngOnInit(): void {
  }

}
