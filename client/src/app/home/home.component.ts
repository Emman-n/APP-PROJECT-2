import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  DifferentMode = false;
//  users: any;

  constructor() {}

  // here is where you add the component initialization
  // in this case is used to initialize the list of users from getUsers()
  ngOnInit(): void {
    // this.getUser();
  }

  ModeToggle() {
    this.DifferentMode = !this.DifferentMode;
  }


  // 
//   getUser() {
//     this.http
//       .get('https://localhost:5001/api/users')
//       .subscribe((users) => (this.users = users));
//   }
// // 


  cancelRegisterMode(event : boolean) {

    this.DifferentMode = event;


    
  }
}
