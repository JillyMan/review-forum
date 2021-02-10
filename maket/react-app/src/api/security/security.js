export const handleResponseRegistration = (response) => {
    console.log(response)
    return response.text().then(text => {
        const data = text;
        if (!response.ok) {
            if ([401, 403].indexOf(response.status) !== -1) {
                return "false"
            }
        }
        console.log(data)
        return data;
    });
}

export const registration = (user) => {
    const url = "http://192.168.100.38:4999/api/users/registration"
    const requestOptions = {
        method: 'POST',
        headers: new Headers({ 'Content-Type': 'application/json' }),
        body: JSON.stringify(user)
    };

    return fetch(url, requestOptions)
        .then(handleResponseRegistration);
}