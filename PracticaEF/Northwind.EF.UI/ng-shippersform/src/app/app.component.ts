import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router'
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogComponent } from './components/dialog/dialog.component';
import { ShippersService } from 'src/app/services/shippers.service';
import { Shipper } from 'src/app/models/shippers';
import { UpdateShippersFormComponent } from '../app/components/update-shippers-form/update-shippers-form.component'
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Shippers form';

  @ViewChild(UpdateShippersFormComponent) addView !: UpdateShippersFormComponent;

  public shipperList: Array<Shipper> = [];
  constructor(private router: Router, private dialog: MatDialog, private shipperService: ShippersService, public dialogRef: MatDialog) { }

  ngOnInit(): void {
    this.obtenerShippers();
  }

  goToPage(pageName: string): void {
    this.router.navigate([`${pageName}`])
  }

  openDialog() {
    this.dialog.open(DialogComponent, {
      width: '30%'
    }).afterClosed().subscribe(val => {
      if (val === 'save')
        this.obtenerShippers();
    })
  }


  openEditDialog(shipper: Shipper) {
    console.log(shipper);
    let dialogRef = this.dialog.open(UpdateShippersFormComponent, {
      width: '30%',
      data: {
        id: shipper.ShipperID,
        companyName: shipper.CompanyName,
        phone: shipper.Phone,
      }
    }).afterClosed().subscribe(val => {
      if (val === 'update')
        this.obtenerShippers();
    })
  }


  editShipper(ShipperID: any) {
    this.dialog.open(DialogComponent),
    {
      width: '30%',
      data: ShipperID
    }
  }

  deleteShipper(ShipperID) {
    this.shipperService.deleteShipper(ShipperID).subscribe({
      next: (res) => {
        alert("Shipper eliminado exitosamente");
        this.obtenerShippers();
      },
      error: () => {
        alert("Error al intentar eliminar los productos");
      }
    })
  }

  obtenerShippers() {
    this.shipperService.getShippers().subscribe({
      next: (res) => {
        this.shipperList = res;
        console.log(this.shipperList)
      },
      error: (err) => {
        alert("Surgio un error al intentar obtener los shippers");
      }
    })
  }
}

