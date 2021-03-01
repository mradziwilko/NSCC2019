package com.nscc.builderexample;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Employee employee = new Employee.EmployeeBuilder("Marshall", "Radziwilko", 39, 1)
                .setPhone("1-902-555-5585")
                .setAddress("North Sydney")
                .setMail("w0256451@nscc.ca").build();

        Log.i("Employee First Name", employee.getFirstName());
        Log.i("Employee Last Name", employee.getLastName());
        Log.i("Employee Age", String.valueOf(employee.getAge()));
        Log.i("Employee Personal ID", String.valueOf(employee.getPersonalId()));
        Log.i("Employee Phone", employee.getPhone());
        Log.i("Employee Address", employee.getAddress());
        Log.i("Employee Mail", employee.getMail());
        TextView fName, lName, age, pid, phone, address, mail;

        fName = findViewById(R.id.fName);
        lName = findViewById(R.id.lName);
        age = findViewById(R.id.Age);
        pid = findViewById(R.id.pID);
        phone = findViewById(R.id.phone);
        address = findViewById(R.id.Address);
        mail = findViewById(R.id.Mail);



        fName.setText("FirstName:" + employee.getFirstName());
        lName.setText("Last Name: " + employee.getLastName());
        age.setText(String.valueOf("Age: " + employee.getAge()));
        pid.setText(String.valueOf("Personal ID: " + employee.getPersonalId()));
        phone.setText("Phone: " + employee.getPhone());
        address.setText("Address: " + employee.getAddress());
        mail.setText("E-Mail: " + employee.getMail());



    }
}