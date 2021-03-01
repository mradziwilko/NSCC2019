package com.nscc.builderexample;

public class Employee {

    // Defines
    private final String firstName, lastName;
    private final int age, personalId;
    private final String phone, address, mail;


    public static class EmployeeBuilder {
        // Defines Local
        private final String firstName, lastName;
        private final int age, personalId;
        private String phone, address, mail;


        public EmployeeBuilder(String firstName, String lastName, int age, int personalId) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.personalId = personalId;
        }
        public EmployeeBuilder setAddress(String address) {
            this.address = address;
            return this;
        }

        public EmployeeBuilder setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public EmployeeBuilder setMail(String mail) {
            this.mail = mail;
            return this;
        }
        public Employee build() {
            return new Employee(this);
        }
    }

    private Employee(EmployeeBuilder builder) {
        // Defines
        this.firstName = builder.firstName;
        this.lastName = builder.lastName;
        this.age = builder.age;
        this.personalId = builder.personalId;
        this.phone = builder.phone;
        this.address = builder.address;
        this.mail = builder.mail;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public int getAge() {
        return age;
    }

    public int getPersonalId() {
        return personalId;
    }

    public String getPhone() {
        return phone;
    }

    public String getAddress() {
        return address;
    }
    public String getMail() {
        return mail;
    }
}
