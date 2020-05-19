function nextDay(yyyy,mm,dd) {
    
    let year = Number(yyyy);
    let month = Number(mm);
    let day = Number(dd);

    let date = new Date(year, month -= 1, day += 1);
 
    let newYear = date.getFullYear();
    let newMonth = date.getMonth();
    let newDate = date.getDate();
 
    console.log(`${newYear}-${newMonth + 1}-${newDate}`);
}
