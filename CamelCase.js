function toCamelCase(str){
let chars = str.split('');
for(let i = 0; i < chars.length; i++) 
    {
        if (chars[i] == "-" || chars[i] == "_") {
          chars[i+1] = chars[i+1].toUpperCase();
          chars.splice(i, 1);
        }
    }
    return chars.join("");
}