package com.nscc.builderexample;

public class User {
    private String firstName;
    private String lastName;
    private int age;

    private User(final Builder builder) {
        firstName = builder.firstName;
        lastName = builder.lastName;
        age = builder.age;
    }

    static class Builder {
        private String firstName;
        private String lastName;
        private int age;

        public Builder setFirstName(final String firstName) {
            this.firstName = firstName;
            return this;
        }
        public String getFirstName() {

            return this.firstName;
        }

        public Builder setLastName(final String lastName) {
            this.lastName = lastName;
            return this;
        }
        public String getLastName() {

            return this.lastName;
        }

        public Builder setAge(final int age) {
            this.age = age;
            return this;
        }
        public int getAge() {
            return this.age;
        }

        public User create() {
            return new User(this);
        }
    }


    
}
