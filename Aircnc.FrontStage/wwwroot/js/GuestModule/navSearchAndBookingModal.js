window.onload = function () {
    // navigation search modal - guests number buttons
    const minusGuestsBtn = document.getElementById('minus-guests')
    const addGuestsBtn = document.getElementById('add-guests')
    const guestNumbers = document.getElementById('guestNumbers')

    let guests = 0

    minusGuestsBtn.addEventListener('click', function () {
        if (guests > 0) {
            guests--
            guestNumbers.value = `${guests}`
        }
    })

    addGuestsBtn.addEventListener('click', function () {
        if (guests < 50) {
            guests++
            guestNumbers.value = `${guests}`
        }
    })

    //room detail page - sticky booking modal - guests number buttons
    const minusBtn = document.getElementById('minus')
    const addBtn = document.getElementById('add')
    const guestNum = document.getElementById('guestNum')

    console.log(minusBtn)
    console.log(addBtn)
    console.log(guestNum)
    let guestForBooking = 0

    minusBtn.addEventListener('click', function () {
        if (guestForBooking > 0) {
            guestForBooking--
            guestNum.value = `${guestForBooking}`
        }
    })

    addBtn.addEventListener('click', function () {
        if (guestForBooking < 50) {
            guestForBooking++
            guestNum.value = `${guestForBooking}`
        }
    })
}
