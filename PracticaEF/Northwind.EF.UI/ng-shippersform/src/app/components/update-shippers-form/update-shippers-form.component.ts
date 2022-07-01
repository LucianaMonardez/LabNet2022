import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Shipper } from 'src/app/models/shippers';
import { ShippersService } from 'src/app/services/shippers.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-update-shippers-form',
  templateUrl: './update-shippers-form.component.html',
  styleUrls: ['./update-shippers-form.component.scss']
})
export class UpdateShippersFormComponent implements OnInit {

  public formShipper = new FormGroup({})
  constructor(private shipperService: ShippersService, private formBuilder: FormBuilder, public dialogRef: MatDialogRef<UpdateShippersFormComponent>) { }

  ngOnInit(): void {
    this.initForm();
  }


  initForm() {

    this.formShipper = this.formBuilder.group({
      telefono: new FormControl('', Validators.required),
      companyName: new FormControl('', Validators.required)
    })
  }
  editShipper(shipper: Shipper) {
    this.formShipper.get('id')?.setValue(shipper.ShipperID);
    this.formShipper.get('companyName')?.setValue(shipper.CompanyName);
    this.formShipper.get('telefono')?.setValue(shipper.Phone);
  }

  cancelarForm() {
    this.formShipper.reset();
  }
  guardarForm() {
    this.shipperService.updateShipper(this.formShipper.value).subscribe({
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

