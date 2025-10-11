function friend(friends){
    let realfriends = [];
    friends.forEach(element => {
        if(element.length == 4) {
            realfriends.push(element)
        }
    });
    return realfriends;
}