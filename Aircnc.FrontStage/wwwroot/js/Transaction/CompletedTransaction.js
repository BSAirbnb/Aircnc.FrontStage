//宣告
let startMonth = document.getElementById('start-month')
let startYear = document.getElementById('start-year')
let endMonth = document.getElementById('end-month')
let endYear = document.getElementById('end-year')
let submitBtn = document.querySelector('.query-submit')
submitBtn.addEventListener('click', function () {
    startMonthSelect()
    startYearSelect()
    endMonthSelect()
    endYearSelect()
})

function startMonthSelect() {
    let a = startMonth.value
    console.log(a)
}
function startYearSelect() {
    let b = startYear.value
    console.log(b)

}
function endMonthSelect() {
    let c = endMonth.value
    console.log(c)

}
function endYearSelect() {
    let d = endYear.value
    console.log(d)
}