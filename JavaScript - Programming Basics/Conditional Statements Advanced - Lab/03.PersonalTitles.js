function personalTitle(inputAge,gender){

    let age = Number(inputAge);

    if (gender == 'f') {
        
        if (age >= 16) {
            console.log("Ms.");
        }
        else{
            console.log("Miss");
        }
    }
    else if(gender == 'm'){

        if (age >= 16) {
            console.log("Mr.");
        }
        else{
            console.log("Master");
        }
    }
}