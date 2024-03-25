import { Component, OnInit } from '@angular/core';
import {MatExpansionModule} from '@angular/material/expansion';
import { FAQModel } from '../../models/faq.model';
import { FAQService } from '../../services/faq.service';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-tree',
  templateUrl: './faq.component.html',
  styleUrl: './faq.component.css',
  imports:[MatExpansionModule,CommonModule ],
  standalone: true
})
export class FAQComponent {
  panelOpenState = false;

  faqs: FAQModel[] = [];

  constructor(private faqService: FAQService) { }

  ngOnInit(): void {
    this.loadContacts();
  }

  loadContacts() {
    this.faqService.getFAQ().subscribe(
      (data) => {
        console.log(data)
        this.faqs = data;
      },
      (error) => {
        console.error('Error fetching contacts:', error);
      }
    );
  }
}