import { Component, OnInit, Inject, ElementRef } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Shipper } from 'src/app/models/shippers';
import { ShippersService } from 'src/app/services/shippers.service';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-update-shippers-form',
  templateUrl: './update-shippers-form.component.html',
  styleUrls: ['./update-shippers-form.component.scss']
})
export class UpdateShippersFormComponent implements OnInit {

  editData: any;
  id = this.data;


  public formShipper = new FormGroup({})
  constructor(private shipperService: ShippersService, private formBuilder: FormBuilder, public dialogRef: MatDialogRef<UpdateShippersFormComponent>, @Inject(MAT_DIALOG_DATA) public data: any) { }



  ngOnInit(): void {
    this.initForm();

  }


  initForm() {

    console.log(this.data);
    this.formShipper = this.formBuilder.group({
      id: new FormControl('', Validators.required),
      phone: new FormControl('', Validators.required),
      companyName: new FormControl('', Validators.required)
    })
    if (this.data) {
      console.log("entro al if");
      console.log(this.id);
      this.formShipper.get('id')?.setValue(this.data.id);
      this.formShipper.get('companyName')?.setValue(this.data.companyName);
      this.formShipper.get('phone')?.setValue(this.data.phone);
    }
  }

  cancelarForm() {
    this.formShipper.reset();
  }
  guardarForm(id) {
    this.shipperService.updateShipper(this.formShipper.getRawValue()).subscribe({
      next: res => {
        alert('Producto actualizado exitosamente');
        this.formShipper.reset();
        this.dialogRef.close('update');
      },
      error: () => {
        alert("Ocurrio un error al intentar actualizar el shipper")
      }
    }
    );
  }
}

