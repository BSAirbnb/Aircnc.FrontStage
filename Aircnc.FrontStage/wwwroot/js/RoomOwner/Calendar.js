
//抓今天日期
const today = new Date()

let year = today.getFullYear()
//month0開始
let month = today.getMonth()
let date = today.getDate()


//Dom

const monthText = document.querySelector('#monthtext')
const months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September',
    'October', 'November', "December"
]

const dateArea = document.querySelector('tbody')

const addModal = document.querySelector('#add-modal')
const editModal = document.querySelector('#edit-modal')
const todoModal = document.querySelector('#todo-modal')

const addDateInput = document.querySelector('#add-date')
const addTitleInput = document.querySelector('#add-title')
const editDateInput = document.querySelector('#edit-date')
const editTitleInput = document.querySelector('#edit-title')

const todoModalText = document.querySelector('.todo-modal-text')

let count = document.querySelector('.count')

window.onload = function () {
    init()
}
function initdropdown() {
    //把下拉選單改成該userid有的所有房源
}
function init() {
    //要傳進日曆使用的data
    ///room roomcalendar

    dateArea.innerHTML = ''
    monthText.innerText = `${year}年${month + 1}月`
    // monthText.innerText = months[month]
    // yearText.innerText = year

    //這個月第一天禮拜幾
    let firstDay = new Date(year, month, 1).getDay()
    //這個月有幾天
    let dayOfMonth = new Date(year, month + 1, 0).getDate()
    //上個月有幾天
    let previousOfMonth = new Date(year, month, 0).getDate()

    let nextMonthDay = 1

    let day = 1
    let rows = Math.ceil((dayOfMonth + firstDay) / 7)



    for (let row = 0; row < rows; row++) {
        let tr = document.createElement('tr')
        for (let col = 0; col < 7; col++) {
            let td = document.createElement('td')
            if (row == 0 && col < firstDay) {
                //上個月
                td.innerText = `${previousOfMonth - firstDay + 1}`
                previousOfMonth++
                td.classList.add('opacity-25')
            } else {
                if (day <= dayOfMonth) {
                    //這個月
                    td.innerText = day
                    //今天之前的日子
                    if (day < today.getDate() && month == today.getMonth() && year == today.getFullYear() ||
                        month < today.getMonth() && year <= today.getFullYear() || year < today.getFullYear()) {
                        td.classList.add('opacity-25')
                    }
                    //今天
                    if (day == today.getDate() && month == today.getMonth() && year == today.getFullYear()) {
                        let TodaySpan = document.createElement('span')
                        TodaySpan.innerText = '今天'
                        TodaySpan.classList.add('fw-bolder')
                        TodaySpan.classList.add('ms-2')
                        td.appendChild(TodaySpan)

                    }
                    //今天和之後 邏輯寫在這邊
                    if (day >= today.getDate() && month == today.getMonth() && year ==
                        today.getFullYear()) {
                        //生成右側選項
                        //將值接過去 
                        //找出有沒有這天的資料from calendar
                        //沒有的話價格跟預定都帶預設值
                        //有的話要帶calendar表的值
                        //寫Crud功能



                    }




                } else {
                    //下個月
                    td.innerText = nextMonthDay
                    nextMonthDay++
                    td.classList.add('opacity-25')
                }
                day++
            }

            tr.append(td)
        }
        dateArea.append(tr)
    }

}

function lastMonth() {
    month--
    if (month == -1) {
        month = 11
        year--
    }
    init()
    monthText.innerText = `${year}年${month + 1}月`
}

function nextMonth() {
    month++
    if (month == 12) {
        month = 0
        year++
    }
    init()
    monthText.innerText = `${year}年${month + 1}月`
}