fetch('https://dummy.restapiexample.com/api/v1/employees', {
    method: 'GET',
    headers: {
        'Accept': 'application/json',
    },
})
   .then(response => response.json())
   .then(response => console.log(JSON.stringify(response)))
   .then(data => console.log(data))
   .then(error => console.log("Error while fetching data",error));

    function displayUser() {
    fetch("https://randomuser.me/api/")
        .then(response => response.json())
        .then(data => {
            const user = data.results[0];
            document.getElementById("userInfo").innerHTML = `
                <p><b>Name:</b>${user.name.title} ${user.name.first} ${user.name.last}</p>
                <p><b>Email:</b> ${user.email}</p>
                <img src="${user.picture.large}" alt="User Image (A person)">
            `;
        })
        .catch(error => console.error("Error in fetching user details:", error));
    };