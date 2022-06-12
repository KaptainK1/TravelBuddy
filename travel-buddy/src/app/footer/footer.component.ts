import { Component, OnInit } from '@angular/core';
import { faCopyright } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

  date: Date = null;
  faCopyright = faCopyright;
  constructor() { }

  ngOnInit(): void {
    this.date = new Date(Date.now());
  }

}
