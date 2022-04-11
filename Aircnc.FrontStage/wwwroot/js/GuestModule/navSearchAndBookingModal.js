window.onload = function () {
    // navigation search modal - guests number buttons
    const minusGuestsBtn = document.getElementById('minus-guests')
    const addGuestsBtn = document.getElementById('add-guests')
    const guestNumbers = document.getElementById('guestNumbers')

    let guests = guestNumbers.value

    guestNumbers.addEventListener('keydown', function(e) {
        e.preventDefault()
    })
    minusGuestsBtn.addEventListener('click', function () {
        if (guests > 0) {
            guests--
            guestNumbers.setAttribute('value', guests)
        }
    })

    addGuestsBtn.addEventListener('click', function () {
        if (guests < 50) {
            guests++
            guestNumbers.setAttribute('value', guests)
        }
    })

    //room detail page - sticky booking modal - guests number buttons
    const minusBtn = document.getElementById('minus')
    const addBtn = document.getElementById('add')
    const guestNum = document.getElementById('guestNum')

    let guestForBooking = guestNum.value

    guestNum.addEventListener('keydown', function (e) {
        e.preventDefault()
    })

    minusBtn.addEventListener('click', function () {
        if (guestForBooking > 0) {
            guestForBooking--
            guestNum.setAttribute('value', guestForBooking)
        }
    })

    addBtn.addEventListener('click', function () {
        if (guestForBooking < 50) {
            guestForBooking++
            guestNum.setAttribute('value', guestForBooking)
        }
    })
}
