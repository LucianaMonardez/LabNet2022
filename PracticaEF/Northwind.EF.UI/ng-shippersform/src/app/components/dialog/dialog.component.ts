import { Component, OnInit, Inject } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Shipper } from 'src/app/models/shippers';
import { ShippersService } from 'src/app/services/shippers.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.scss']
})
export class DialogComponent implements OnInit {

  public formShipper = new FormGroup({})

  constructor(private shipperService: ShippersService,
    private formBuilder: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public editData: any,
    public dialogRef: MatDialogRef<DialogComponent>) { }

  ngOnInit(): void {
    this.formShipper = this.formBuilder.group({
      telefono: new FormControl('', Validators.required),
      companyName: new FormControl('', Validators.required)
    })

    /*    if (this.editData) {
          this.formShipper.controls['companyName'].setValue(this.editData.companyName);
          this.formShipper.controls['telefono'].setValue(this.editData.telefono);
        }*/
  }

  cancelarForm() {
    this.formShipper.reset();
  }
  guardarForm() {
    if (this.formShipper.valid) {
      var shipper = new Shipper();
      shipper.Phone = this.formShipper.get('telefono').value;
      shipper.CompanyName = this.formShipper.get('companyName').value;
      this.shipperService.createShipper(shipper).subscribe({
        next: (res) => {
          alert('Shipper creado exitosamente')
          this.formShipper.reset();
          this.dialogRef.close('save');
        },
        error: () => {
          alert("Error al intentar crear un shipper")
        }
      }
      );
    }
  }


}
