/*
		----------------------------------------------------------------------------
        'Program Info
        '----------------------------------------------------------------------------
        'Program: Assignment 1 - Converter
        'Date: 16/09/2020
        'Author: Marshall Radziwilko
        'Operation:
            Using the examples covered in class, create an Android app that contains text fields to
            collect a user's name and a temperature value in Celsius. When the user clicks a button,
            the temperature in Fahrenheit and the user's name is to be displayed within a text label.
            Properly constrain all graphic elements
        '-----------------------------------------------------------------------------
        'Change Log
        '-----------------------------------------------------------------------------
        'Date Programmer Change
        '16/09/2020 - Created Initial Program
        '-----------------------------------------------------------------------------

 */
package com.nscc.converter;

import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.os.Bundle;
import android.text.InputType;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import static android.widget.Toast.LENGTH_SHORT;

public class MainActivity extends AppCompatActivity {

    // Fast easy Conversion
    private double convCtoF(double celsius) {
        return ((celsius * 9) / 5) + 32;
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Set Text of Inputs and Editboxes
        Button clickButton = findViewById(R.id.btnConvert);
        final EditText nameinp = findViewById(R.id.inpName);
        final EditText tempinp = findViewById(R.id.inpTemp);
        final TextView textConv = findViewById(R.id.txtConv);
        final TextView textName = findViewById(R.id.txtName);


        // In Button Click Calculate temp and set name.
        clickButton.setOnClickListener( new View.OnClickListener() {



            @Override
            public void onClick(View v) {
                // Grab Name from Edit box
                String name = nameinp.getText().toString();


                // Make sure Values are not empty, if empty set Toast for error and don't continue.
                if (name.matches("")) {
                    Toast.makeText(MainActivity.this, "Error: Your name is Empty.", LENGTH_SHORT).show();
                    return;
                }

                if (tempinp.getText().toString().matches("")) {
                    Toast.makeText(MainActivity.this, "Error: Temperature is Empty.", LENGTH_SHORT).show();
                    return;
                }

                // Get Heat Value.
                float temprature = Float.parseFloat(tempinp.getText().toString());


                // Set Text
                textName.setText(name);

                // Convert Temperature and Set Text with F After Text.
                textConv.setText(convCtoF(temprature) + " \u2109");

            }
        });

    }
}