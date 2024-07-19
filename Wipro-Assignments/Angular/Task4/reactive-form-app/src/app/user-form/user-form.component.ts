import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent implements OnInit {
  userForm!: FormGroup;

  constructor(private fb: FormBuilder, private http: HttpClient) {}

  ngOnInit(): void {
    this.userForm = this.fb.group({
      firstName: ['', Validators.required],
      middleName: [''],
      lastName: ['', Validators.required],
      age: ['', [Validators.required, Validators.min(0), Validators.max(100)]],
      dateOfBirth: ['', Validators.required],
      emailId: ['', [Validators.required, Validators.email]],
      country: ['', Validators.required],
      gender: ['', Validators.required]
    });
  }

  // emailDomainValidator(control: AbstractControl): { [key: string]: boolean } | null {
  //   const email: string = control.value;
  //   const domain = email.substring(email.lastIndexOf('@') + 1);
  //   if (email === '' || domain.toLowerCase() === 'valid.com') {
  //     return null;
  //   } else {
  //     return { 'emailDomain': true };
  //   }
  // }

  onSubmit(): void {
    if (this.userForm.valid) {
      this.http.post('http://localhost:3000/users', this.userForm.value).subscribe(response => {
        console.log('User saved', response);
      });
    }
  }
}
