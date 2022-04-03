window.onload = function () {
    const minusGuestsBtn = document.getElementById('minus-guests')
    const addGuestsBtn = document.getElementById('add-guests')
    const guestNubmers = document.getElementById('guestNumbers')

    let guests = 0

    minusGuestsBtn.addEventListener('click', function () {
        if (guests > 0) {
            guests--
            guestNubmers.value = `${guests}`
        }
    })

    addGuestsBtn.addEventListener('click', function () {
        if (guests < 50) {
            guests++
            guestNubmers.value = `${guests}`
        }
    })
}
