function theatrePromotions(dayType, age) {
    let price;

    if (age < 0 || age > 122) {
        console.log('Error!');
        return;
    }

    if (age >= 0 && age <= 18) {
        
        if (dayType === 'Weekday') {
            price = 12.00;
        
        } else if (dayType === 'Weekend') {
            price = 15.00;
        
        } else if (dayType === 'Holiday') {
            price = 5.00;
        }

    } else if (age > 18 && age <= 64) {
       
        if (dayType === 'Weekday') {
            price = 18.00;
         
        } else if (dayType === 'Weekend') {
            price = 20.00;
         
        } else if (dayType === 'Holiday') {
            price = 12.00;
        }
 
    } else if (age > 64 && age <= 122) {
        
        if (dayType === 'Weekday') {
            price = 12.00;
        
        } else if (dayType === 'Weekend') {
            price = 15.00;
       
        } else if (dayType === 'Holiday') {
            price = 10.00;
        }
    }

    console.log(`${price}$`);
}


theatrePromotions('Weekday', 5);
theatrePromotions('Weekend', 27);  
theatrePromotions('Holiday', 70);  
theatrePromotions('Weekday', -5);  
theatrePromotions('Holiday', 150);  