import { HttpClient } from '@angular/common/http';
import { Component, Inject, NgModule } from '@angular/core';
import { FormControl, FormGroup, FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';



@Component({
  selector: 'app-add-disc',
  templateUrl: './add-disc.component.html',
  styleUrls: ['./add-disc.component.css']
})


export class AddDiscComponent {

  public discs: Disc[] = [];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string)
  {
    http.get<Disc[]>(baseUrl + 'discs').subscribe(result => {
      this.discs = result;
    }, error => console.error(error));
  }

  discsForm = new FormGroup({
    discName2: new FormControl(),
    discType2: new FormControl()
  })

  discName: any;
  discType: any;

  addedDiscs: any[] = [];
  addedDiscs2: any[] = [];

  addDisc() {

    console.log('asd')
    let disc = {
      name: this.discName,
      type: this.discType
    }

    this.addedDiscs.push(disc);

  }

  addDisc2() {
    let formData = this.discsForm.getRawValue();
    let discName2 = formData.discName2;
    let discType2 = formData.discType2;

 

    let disc = {
      discName2: discName2,
      discType2: discType2
    }

    console.log(disc)

    this.addedDiscs2.push(disc)
  }




}

interface Disc {
  id: number;
  name: String;
  type: String;
  color: String;
  speed: number;
  glide: number;
  turn: number;
  fade: number;
}
