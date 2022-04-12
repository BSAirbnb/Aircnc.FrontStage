

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

    

    //判斷搜尋中 "位置" 欄位是否為空
    const location = document.getElementById('location-field')
    const searchBtn = document.getElementById('search-btn')
    const msg = document.getElementById('location-msg')

    if (location.value != null) {
        searchBtn.disabled = false
        msg.innerText = ''
    }
    else {
        searchBtn.disabled = true
        msg.innerText = '位置 為必填欄位'
    }
    

    location.addEventListener('change', function () {
        if (location.value == null || location.value == '') {
            searchBtn.disabled = true
            msg.innerText = '位置 為必填欄位'
        }
        else {
            searchBtn.disabled = false
            msg.innerText = ''
        }
    })
    searchBtn.addEventListener('click', function () {
    if (location.value == null) {
            let msg = document.createElement('span')
            msg.innerText = '位置 為必填欄位'
            msg.setAttribute('class', 'text-danger')
            location.append(msg)
        }
    })
    
}
