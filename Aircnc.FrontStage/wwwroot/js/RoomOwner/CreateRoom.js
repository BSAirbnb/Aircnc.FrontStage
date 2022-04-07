
var step = 1;


$(".next").on("click", function () {
    if (step < $(".step").length) {
        // 所有頁面秀出來
        $(".step").show();
        //不是當前頁面都隱藏
        $(".step")
            .not(":eq(" + step++ + ")")
            .hide();
        // console.log(step);
    }
});

// ON CLICK BACK BUTTON
$(".back").on("click", function () {
    // console.log(step);
    if (step > 1) {
        step = step - 2;
        $(".step").show();
        $(".step")
            .not(":eq(" + step++ + ")")
            .hide();
    }
    // console.log(step);

});





function checkForm(val) {
    // CHECK IF ALL "REQUIRED" FIELD ALL FILLED IN
    var valid = true;
    $("#" + val + " input:required").each(function () {
        if ($(this).val() === "") {
            $(this).addClass("is-invalid");
            valid = false;
        } else {
            $(this).removeClass("is-invalid");
        }
    });
    return valid;
}


// 第一頁
//Dom
const OptionsRow1 = document.querySelector(".OptionsRow1")

let OptionsRow1Btns = OptionsRow1.querySelectorAll("button")
OptionsRow1Btns.forEach(OptionsRow1Btn => {
    OptionsRow1Btn.addEventListener("click", () => {
        OptionsRow1Btns.forEach(item => {
            item.setAttribute("class", "col-8 OptionCards d-flex justify-content-between  btn bg-white ")
        })
        OptionsRow1Btn.setAttribute("class", "col-8 OptionCards d-flex justify-content-between  btn bg-white btn_chosed")
        $(".next")[0].disabled = false
    })
});


// 第二頁
//Dom
const OptionsRow2 = document.querySelector(".OptionsRow2")

let OptionsRow2Btns = OptionsRow2.querySelectorAll("button")
OptionsRow2Btns.forEach(OptionsRow2Btn => {
    OptionsRow2Btn.addEventListener("click", () => {
        OptionsRow2Btns.forEach(item => {
            item.setAttribute("class", "col-8 OptionCards d-flex justify-content-between  btn bg-white ")

        })
        OptionsRow2Btn.setAttribute("class", "col-8 OptionCards d-flex justify-content-between  btn bg-white btn_chosed")
        $(".next")[1].disabled = false
    })

});
// 第三頁 googlemap
//Dom
const Input_Street = document.getElementById("input_street")
const Input_District = document.getElementById("input_district")
const Input_City = document.getElementById("input_city")
const Input_Country = document.getElementById("input_country")
const Btn_submitAddressDetail = document.getElementById("btn_submitAddressDetail")
const Area_detail_address = document.getElementById("detail_address")
// 全部的detail input
const Detail_inputs = document.querySelectorAll(".OptionsRow3>#detail_address input")
//DOm google搜尋框
const Area_first_address = document.getElementById('first_address')
const input_first_address = document.querySelector("#input_first_address")
//google搜尋後的重設
const btn_check_address = document.getElementById("btn_check_address")

const btn_backToGoogleSearch = document.getElementById('btn_backToGoogleSearch')

//detail submit onclick
console.log(Area_first_address);
// 宣告lat lng 記得送出表單要來這邊拿值
let place, mylat, mylng
//當值被改地點沒換要重輸入
input_first_address.addEventListener('change', () => {
    btn_check_address.disabled = true
    $(".next")[2].disabled = true
})
btn_check_address.addEventListener('click', () => {
    Input_Street.value = ""
    Input_District.value = ""
    Input_City.value = ""
    Input_Country.value = ""
    //如果地址不符
    try {
        Input_Street.value = place.address_components[1].long_name + place.address_components[0].long_name
        Input_District.value = place.address_components[3].long_name
        Input_City.value = place.address_components[4].long_name
        Input_Country.value = place.address_components[5].long_name
    } catch (error) {
        alert('地址不符格式')
        return
    }




    Area_detail_address.setAttribute('class', 'col-12 col-md-8 d-flex align-content-between');
    Area_first_address.setAttribute("class", "col-12 col-md-8 d-none")

})
btn_backToGoogleSearch.addEventListener('click', () => {

    Area_detail_address.setAttribute('class', 'col-12 col-md-8 d-none align-content-between');
    Area_first_address.setAttribute("class", "col-12 col-md-8 d-block")
})
Btn_submitAddressDetail.addEventListener('click', () => {
    Area_detail_address.setAttribute('class', 'col-12 col-md-8 d-none align-content-between');
    Area_first_address.setAttribute("class", "col-12 col-md-8 d-block")
    if (mylat != null && mylng != null) {
        $(".next")[2].disabled = false
    }
    console.log(mylat)
    console.log(mylng)
    console.log(Input_Street.value)
    console.log(Input_District.value)
    console.log(Input_City.value)
    console.log(Input_Country.value)

})

// Btn_submitAddressDetail.addEventListener('click', () => {
//     let Detail_inputs_array = [Input_Street.value, Input_District.value, Input_City.value, Input_Country.value]

//     //判斷輸入的地址是不是null 把地址帶入google搜尋
//     if (Detail_inputs_array.every(x => x.trim(" ") != null) && Detail_inputs_array.every(x => x.trim(" ") != "")) {
//         Area_detail_address.setAttribute('class', "col-12 col-md-8 d-flex align-content-between d-none")
//         //將詳細資料輸入的組合成地址
//         toGoogleSerch = Input_Country.value + Input_City.value + Input_District.value + Input_Street.value
//         input_first_address.value = toGoogleSerch
//         Area_detail_address.setAttribute('class', 'col-12 col-md-8 d-none align-content-between');
//         Area_first_address.setAttribute("class", "col-12 col-md-8 d-block");
//     }
//     //重設一次地址btn
//     btn_reset_address.addEventListener('click', () => {
//         Area_detail_address.setAttribute('class', 'col-12 col-md-8 d-flex align-content-between')
//         Area_first_address.setAttribute("class", "col-12 col-md-8 d-none")
//         //要等重新送出地址才能開啟下一步
//         $(".next")[2].disabled = true
//     })
// })




function initMap() {
    var uluru = {
        lat: 25.030,
        lng: 121.553
    };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 10,
        center: uluru
    });
    var marker = new google.maps.Marker({
        position: uluru,
        map: map
    });
    //限定搜尋結果在台灣
    var options = {
        componentRestrictions: { country: 'tw' }
    };

    const searchBox = new google.maps.places.Autocomplete(input_first_address, options);
    searchBox.addListener('place_changed', () => {
        place = searchBox.getPlace();
        console.log(place);
        mylat = place.geometry.location.lat();
        mylng = place.geometry.location.lng();
        btn_check_address.disabled = false
        map = new google.maps.Map(document.getElementById('map'), {
            zoom: 18,
            center: map.center = { lat: mylat, lng: mylng },

        });

        marker.setMap(null)

        marker = new google.maps.Marker({
            position: { lat: parseFloat(mylat), lng: parseFloat(mylng) },
            map: map
        });
    })


}
// searchbox




//第四頁
const OptionsRow4 = document.querySelector(".OptionsRow4")
const calcSets = OptionsRow4.querySelectorAll(".form-outline>span:nth-child(2)")

calcSets.forEach(calcSet => {
    let clacSetValue = calcSet.querySelector("span")
    clacSetValue.setAttribute("style", "display:inline-block; width:3rem; text-align: center;")
    let clacSetMinus = calcSet.querySelector("button:nth-child(1)")
    let clacSetAdd = calcSet.querySelector("button:nth-child(3)")

    clacSetMinus.addEventListener("click", () => {
        if (parseInt(clacSetValue.innerText) > 0) {
            clacSetValue.innerText = (parseInt(clacSetValue.innerText) - 1).toString();
        }
    })
    clacSetAdd.addEventListener("click", () => {
        if (parseInt(clacSetValue.innerText) < 15) {
            clacSetValue.innerText = (parseInt(clacSetValue.innerText) + 1).toString();
        }
    })
})

// 第五頁
//Dom
const OptionsRow5 = document.querySelector(".OptionsRow5")
//左邊右邊的class不一樣
const OptionsRow5BtnsOdd = OptionsRow5.querySelectorAll("button:nth-child(odd)")
const OptionsRow5BtnsEven = OptionsRow5.querySelectorAll("button:nth-child(even)")
//奇數
OptionsRow5BtnsOdd.forEach(OptionsRow5Btn => {
    OptionsRow5Btn.addEventListener("click", () => {
        if (OptionsRow5Btn.classList.contains("btn_chosed")) {
            OptionsRow5Btn.setAttribute("class", "col-5 OptionCards d-flex ms-auto me-3 mt-5 btn bg-white justify-content-center ")
        }
        else {
            OptionsRow5Btn.setAttribute("class", "col-5 OptionCards d-flex ms-auto me-3 mt-5 btn bg-white justify-content-center btn_chosed")
        }
    })
});
//偶數
OptionsRow5BtnsEven.forEach(OptionsRow5Btn => {
    OptionsRow5Btn.addEventListener("click", () => {
        if (OptionsRow5Btn.classList.contains("btn_chosed")) {
            OptionsRow5Btn.setAttribute("class", "col-5 OptionCards d-flex me-auto mt-md-5 btn bg-white justify-content-center")
        }
        else {
            OptionsRow5Btn.setAttribute("class", "col-5 OptionCards d-flex me-auto mt-md-5 btn bg-white justify-content-center btn_chosed")
        }
    })
});
// p7 房源名稱
//Dom
const OptionsRow7 = document.querySelector(".OptionsRow7")
const RoomTitleTextArea = OptionsRow7.querySelector("#RoomTitle")


RoomTitleTextArea.addEventListener("change", () => {
    if (RoomTitleTextArea.value.trim(" ") != "" && RoomTitleTextArea.value != null) {
        $(".next")[6].disabled = false
    }
    else {
        $(".next")[6].disabled = true
    }
})



// p8 房源描述
//Dom
const OptionsRow8 = document.querySelector(".OptionsRow8")
const RoomDesrcibeTextArea = OptionsRow8.querySelector("#RoomDesrcibe")


RoomDesrcibeTextArea.addEventListener("change", () => {
    if (RoomDesrcibeTextArea.value.trim(" ") != "" && RoomDesrcibeTextArea.value != null) {
        $(".next")[7].disabled = false
    }
    else {
        $(".next")[7].disabled = true
    }
})
//p9 價格

const OptionsRow9 = document.querySelector(".OptionsRow9")
const btn_price_minus = OptionsRow9.querySelector("#btn_price_minus")
const input_price = OptionsRow9.querySelector("#input_price")
const btn_price_plus = OptionsRow9.querySelector("#btn_price_plus")

btn_price_minus.addEventListener("click", () => {
    if (parseInt(input_price.value) >= 50) {
        input_price.value = parseInt(input_price.value) - 50
    }
    else {
        input_price.value = 0
    }

})

btn_price_plus.addEventListener("click", () => {

    input_price.value = parseInt(input_price.value) + 50



})
//要傳出去的變數
let result = {}







//建立房源按鈕
const btn_CreateRoom = document.querySelector('#btn_CreateRoom')

btn_CreateRoom.addEventListener('click', () => {

    //p1 Housetype
    OptionsRow1Btns.forEach((x, index) => {
        if (x.classList.contains('btn_chosed')) {
            result.HouseType = index + 1
        }

    })
    //p2 Roomtype
    OptionsRow2Btns.forEach((x, index) => {
        if (x.classList.contains('btn_chosed')) {
            result.RoomType = index + 1
        }

    })
    //p3 map 
    result.Lat = mylat
    result.Lng = mylng
    result.Street = Input_Street.value
    result.District = Input_District.value
    result.City = Input_City.value
    result.Country = Input_Country.value

    //p4 數量
    const num_pax = document.getElementById('num_pax')
    const num_bed = document.getElementById('num_bed')
    const num_room = document.getElementById('num_room')
    const num_bathroom = document.getElementById('num_bathroom')
    result.Pax = num_pax.innerText
    result.BedCount = num_bed.innerText
    result.RoomCount = num_room.innerText
    result.BathroomCount = num_bathroom.innerText
    //p5 service label
    let serviceLabel = []
    const OptionsRow5Btns = OptionsRow5.querySelectorAll('button')
    OptionsRow5Btns.forEach((x, index) => {
        if (x.classList.contains('btn_chosed')) {
            let labelenum = index + 1
            serviceLabel.push(labelenum)
        }
    })
    result.RoomServiceLabel = serviceLabel
    result.RoomName = RoomTitleTextArea.value
    result.RoomDescription = RoomDesrcibeTextArea.value
    result.UnitPrice = input_price.value
    console.log(result);

    fetch("/RoomOwner/CreateRoom", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)

    })
        .then(response => response.json())
        .then(jsonData => {
            console.log(jsonData)
            //the url need to be changed
/*            window.location.href = "/controller/action"*/
            let url = "/RoomOwner/HostList"
            
            
            location.href = url


        })
       
})





