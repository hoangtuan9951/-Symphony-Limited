// home.component.ts

import { AfterViewInit, Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'search-core',
  templateUrl: './searchScore.component.html',
  styleUrls: ['./searchScore.component.scss']
})
export class SearchScore {
  displayedColumns: string[] = ['No', 'name', 'class', 'score'];
  dataSource = new MatTableDataSource<ScoreElement>(ELEMENT_DATA);
}

export interface ScoreElement {
  id: number | null;
  name: string;
  class: string;
  score: string;
}

const ELEMENT_DATA: ScoreElement[] = [
  {
    id: 1,
    name: 'Alajandro',
    class: 'PHP',
    score: '30',
  },
  {
    id: 2,
    name: 'Alajandro',
    class: 'REACTJS',
    score: '30',
  },
  {
    id: 3,
    name: 'Alajandro',
    class: 'NODEJS',
    score: '20',
  },
  {
    id: 4,
    name: 'Alajandro',
    class: 'JAVA',
    score: '20',
  },
];

