import { Component } from '@angular/core';
import { CardSettingsModel } from '@syncfusion/ej2-angular-kanban';
import { HttpClient } from "@angular/common/http";
import { CommonModule } from '@angular/common';
import { KanbanModule } from '@syncfusion/ej2-angular-kanban';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, KanbanModule],
  templateUrl: './home.component.html'
})
export class HomeComponent {
  public cardSettings: CardSettingsModel = {
    headerField: 'Id',
    contentField: 'Summary'
  };
  KanbanData: Object;
  constructor(private http: HttpClient) { }
  ngOnInit() {
    this.http.get('https://localhost:44335/api/Kanban/').subscribe(result => {
      this.KanbanData = result;
    })
  }  
}
