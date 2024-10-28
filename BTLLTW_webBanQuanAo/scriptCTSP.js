function addClick() {
    // Use the server-generated ClientID
    var quantity = document.getElementById('<%= number_quantity.ClientID %>');
    var quantityValue = parseInt(quantity.value);

    quantityValue += 1;
    quantity.value = quantityValue;

    console.log(quantity.value);
}

function removeClick() {
    // Use the server-generated ClientID
    var quantity = document.getElementById('<%= number_quantity.ClientID %>');
    var quantityValue = parseInt(quantity.value);

    if (quantityValue > 1) {
        quantityValue -= 1;
        quantity.value = quantityValue;
    }
}

function cartAddClick() {
    var cartQuantity = document.getElementById('number');
    var cartQuantityValue = parseInt(cartQuantity.innerHTML);
    var quantityValue = parseInt(document.getElementById('number_quantity').value);

    cartQuantityValue += quantityValue;
    cartQuantity.innerHTML = cartQuantityValue;
}
