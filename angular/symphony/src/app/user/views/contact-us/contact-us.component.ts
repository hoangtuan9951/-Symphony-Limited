import { Component } from '@angular/core';
import { ContactUsService } from '../../services/contactus.service';
import { Contact } from '../../models/contactus.model';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrl: './contact-us.component.css'
})
export class ContactUsComponent {
  contacts: Contact[] = [];

  constructor(private contactusService: ContactUsService) { }

  ngOnInit(): void {
    this.loadContacts();
  }

  loadContacts() {
    this.contactusService.getContacts().subscribe(
      (data) => {
        console.log(data)
        this.contacts = data;
      },
      (error) => {
        console.error('Error fetching contacts:', error);
      }
    );
  }
}
