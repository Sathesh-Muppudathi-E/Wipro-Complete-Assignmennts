function validateForm() {
    // Grab form and input elements
    var form = document.getElementById('employeeForm');
    var firstName = document.getElementById('firstName');
    var middleName = document.getElementById('middleName');
    var lastName = document.getElementById('lastName');
    var email = document.getElementById('email');
    var age = document.getElementById('age');
    var gender = document.getElementsByName('gender');
    var dob = document.getElementById('dob');
    var country = document.getElementById('country');
    var state = document.getElementById('state');
    var city = document.getElementById('city');
    var position = document.getElementById('position');
    var salary = document.getElementById('salary');
    var terms = document.getElementById('terms');

    // Grab error elements
    var firstNameError = document.getElementById('firstNameError');
    var middleNameError = document.getElementById('middleNameError');
    var lastNameError = document.getElementById('lastNameError');
    var emailError = document.getElementById('emailError');
    var ageError = document.getElementById('ageError');
    var genderError = document.getElementById('genderError');
    var dobError = document.getElementById('dobError');
    var countryError = document.getElementById('countryError');
    var stateError = document.getElementById('stateError');
    var cityError = document.getElementById('cityError');
    var positionError = document.getElementById('positionError');
    var salaryError = document.getElementById('salaryError');
    var termsError = document.getElementById('termsError');

    // Reset error messages
    firstNameError.textContent = '';
    middleNameError.textContent = '';
    lastNameError.textContent = '';
    emailError.textContent = '';
    ageError.textContent = '';
    genderError.textContent = '';
    dobError.textContent = '';
    countryError.textContent = '';
    stateError.textContent = '';
    cityError.textContent = '';
    positionError.textContent = '';
    salaryError.textContent = '';
    termsError.textContent = '';

    var isValid = true;

    // Validate input fields
    if (!firstName.value) {
        firstNameError.textContent = 'Please provide First Name';
        firstName.classList.add('invalid');
        isValid = false;
    } else {
        firstName.classList.add('valid');
    }

    if (!middleName.value) {
        middleNameError.textContent = 'Please provide Middle Name';
        middleName.classList.add('invalid');
        isValid = false;
    } else {
        middleName.classList.add('valid');
    }

    if (!lastName.value) {
        lastNameError.textContent = 'Please provide Last Name';
        lastName.classList.add('invalid');
        isValid = false;
    } else {
        lastName.classList.add('valid');
    }

    if (!email.value) {
        emailError.textContent = 'Please provide Email';
        email.classList.add('invalid');
        isValid = false;
    } else {
        email.classList.add('valid');
    }

    if (!age.value) {
        ageError.textContent = 'Please provide Age';
        age.classList.add('invalid');
        isValid = false;
    } else {
        age.classList.add('valid');
    }

    var genderChecked = false;
    for (var i = 0; i < gender.length; i++) {
        if (gender[i].checked) {
            genderChecked = true;
            break;
        }
    }
    if (!genderChecked) {
        genderError.textContent = 'Please select Gender';
        isValid = false;
    }

    if (!dob.value) {
        dobError.textContent = 'Please provide Date of Birth';
        dob.classList.add('invalid');
        isValid = false;
    } else {
        dob.classList.add('valid');
    }

    if (!country.value) {
        countryError.textContent = 'Please select Country';
        country.classList.add('invalid');
        isValid = false;
    } else {
        country.classList.add('valid');
    }

    if (!state.value) {
        stateError.textContent = 'Please select State';
        state.classList.add('invalid');
        isValid = false;
    } else {
        state.classList.add('valid');
    }

    if (!city.value) {
        cityError.textContent = 'Please select City';
        city.classList.add('invalid');
        isValid = false;
    } else {
        city.classList.add('valid');
    }

    if (!position.value) {
        positionError.textContent = 'Please provide Position';
        position.classList.add('invalid');
        isValid = false;
    } else {
        position.classList.add('valid');
    }

    if (!salary.value) {
        salaryError.textContent = 'Please provide Salary';
        salary.classList.add('invalid');
        isValid = false;
    } else {
        salary.classList.add('valid');
    }

    if (!terms.checked) {
        termsError.textContent = 'You must accept the terms and conditions';
        isValid = false;
    }

    // If form is valid, log values to console and write them to document
    if (isValid) {
        console.log('First Name:', firstName.value);
        console.log('Middle Name:', middleName.value);
        console.log('Last Name:', lastName.value);
        console.log('Email:', email.value);
        console.log('Age:', age.value);
        console.log('Gender:', document.querySelector('input[name="gender"]:checked').value);
        console.log('Date of Birth:', dob.value);
        console.log('Country:', country.value);
        console.log('State:', state.value);
        console.log('City:', city.value);
        console.log('Position:', position.value);
        console.log('Salary:', salary.value);
        console.log('Terms Accepted:', terms.checked);

        document.write(`
            <h2>Employee Data</h2>
            <p>First Name: ${firstName.value}</p>
            <p>Middle Name: ${middleName.value}</p>
            <p>Last Name: ${lastName.value}</p>
            <p>Email: ${email.value}</p>
            <p>Age: ${age.value}</p>
            <p>Gender: ${document.querySelector('input[name="gender"]:checked').value}</p>
            <p>Date of Birth: ${dob.value}</p>
            <p>Country: ${country.value}</p>
            <p>State: ${state.value}</p>
            <p>City: ${city.value}</p>
            <p>Position: ${position.value}</p>
            <p>Salary: ${salary.value}</p>
            <p>Terms Accepted: ${terms.checked}</p>
        `);
    }
}