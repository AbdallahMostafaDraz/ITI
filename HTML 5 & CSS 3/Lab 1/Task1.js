document.addEventListener("DOMContentLoaded", function() {
    const emailData = document.querySelector("#EmailAdress");
    const passData = document.querySelector("#Password");
    const changeBtn = document.querySelector("#Button");
    const checkedBox = document.querySelector("#RememberMe");
    const divContent = document.querySelector("#inText");
    const form = document.querySelector("#FormOne");
    const emailError = document.querySelector("#emailError");
    const passError = document.querySelector("#passError");

    // Load saved data on page load
    if (localStorage.getItem("Remember") === "true") {
        emailData.value = localStorage.getItem("Email") || "";
        passData.value = localStorage.getItem("Password") || "";
        checkedBox.checked = true;
        displayContent();
    }

    // Form submission handler
    form.addEventListener("submit", function(e) {
        e.preventDefault();

        // Email validation
        const emailPattern = /[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/;
        if (!emailPattern.test(emailData.value)) {
            emailError.textContent = "Please enter a valid email";
            return;
        } else {
            emailError.textContent = "";
        }

        // Password validation
        const passPattern = /(?=.*\d)(?=.*[a-zA-Z]).{6,}/;
        if (!passPattern.test(passData.value)) {
            passError.textContent = "Password does not meet requirements";
            return;
        } else {
            passError.textContent = "";
        }

        // Save to localStorage
        localStorage.setItem("Email", emailData.value);
        localStorage.setItem("Password", passData.value);
        localStorage.setItem("Remember", checkedBox.checked);

        // Display content if checkbox is checked
        if (checkedBox.checked) {
            displayContent();
        } else {
            divContent.innerHTML = "";
        }
    });

    // Function to display stored content
    function displayContent() {
        divContent.innerHTML = `
            <p>Email: ${localStorage.getItem("Email")}</p>
            <p>Password: ${localStorage.getItem("Password")}</p>
        `;
        divContent.style.opacity = "1";
    }
});