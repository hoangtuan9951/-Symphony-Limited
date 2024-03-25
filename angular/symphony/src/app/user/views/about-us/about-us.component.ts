import { Component } from '@angular/core';
import { AboutUs } from '../../models/abountus.model';
import { AboutUsService } from '../../services/abountus.service';

@Component({
  selector: 'app-about-us',
  templateUrl: './about-us.component.html',
  styleUrl: './about-us.component.css'
})
export class AboutUsComponent {
   aboutUs: AboutUs | undefined;

   constructor(private service: AboutUsService) {
    }
 
   ngOnInit(): void {
     this.loadContacts();
   }
 
   loadContacts() {
     this.service.get().subscribe(
       (data) => {
         console.log(data)
         this.aboutUs = data[0];
         console.log(this.aboutUs)
       },
       (error) => {
         console.error('Error fetching contacts:', error);
       }
     );
   }

}
