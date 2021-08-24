function SaveAsFile(filename, byteBase64){
    var link = document.createElement('a');
    link.download = filename;
    link.href = 'data:application/vnd.openxmlformats-pfficedocument.spreadsheetml.sheet;base64,'+byteBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
    
}

window.boton= function initPayPalButton() {
    paypal.Buttons({
        style: {
            color: 'silver',
            shape: 'pill',
            label: 'paypal',
            layout: 'vertical',

        },
        createOrder: function(data, actions) {
            return actions.order.create({
                purchase_units: [{
                    amount: {
                        value: '9999'
                    }
                }]
            });
        },

        // Finalize the transaction
        onApprove: function(data, actions) {
            return actions.order.capture().then(function(orderData) {
                // Successful capture! For demo purposes:
                console.log('Capture result', orderData, JSON.stringify(orderData, null, 2));
                var transaction = orderData.purchase_units[0].payments.captures[0];
                alert('Transaction '+ transaction.status + ': ' + transaction.id + '\n\nSee console for all available details');

            });
        }

    }).render('#paypal-button-container');
}
initPayPalButton();