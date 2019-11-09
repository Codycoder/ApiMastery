function getRequest(location, callback){
    fetch(location)
    .then(response => response.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

function postRequest(location, requestBody, callback){
    fetch(location, {
        method:"POST",
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })
    .then(response => response.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

function deleteRequest(location, callback) {
    fetch(location, {
        method: "DELETE",
        headers: {
            "Content-Type": "application/json"
        }
    })

    .then(response => response.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

function putRequest(location, requestBody, callback) {
    fetch(location, {
        method:"PUT",
        body: JSON.stringify(requestBody),
        headers: {
            "Content-Type": "application/json"
        }
    })

    .then(response => response.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

export default{
    getRequest,
    postRequest,
    deleteRequest,
    putRequest
};