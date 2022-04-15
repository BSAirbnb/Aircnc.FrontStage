document.querySelectorAll(".drop-zone__input").forEach((inputElement) => {
    const dropZoneElement = inputElement.closest(".drop-zone");
    console.log(dropZoneElement);
    dropZoneElement.addEventListener("click", (e) => {
        inputElement.click();
    });

    inputElement.addEventListener("change", (e) => {
        if (inputElement.files.length) {
            updateThumbnail(dropZoneElement, inputElement.files[0]);
        }
    });

    dropZoneElement.addEventListener("dragover", (e) => {
        e.preventDefault();
        dropZoneElement.classList.add("drop-zone--over");
    });

    ["dragleave", "dragend"].forEach((type) => {
        dropZoneElement.addEventListener(type, (e) => {
            dropZoneElement.classList.remove("drop-zone--over");
        });
    });

    dropZoneElement.addEventListener("drop", (e) => {
        e.preventDefault();

        if (e.dataTransfer.files.length) {
            inputElement.files = e.dataTransfer.files;
            updateThumbnail(dropZoneElement, e.dataTransfer.files[0]);
        }

        dropZoneElement.classList.remove("drop-zone--over");
    });
});

function updateThumbnail(dropZoneElement, file) {
    let thumbnailElement = dropZoneElement.querySelector(".drop-zone__thumb");

    if (dropZoneElement.querySelector(".drop-zone__prompt")) {
        dropZoneElement.querySelector(".drop-zone__prompt").remove();
    }

    if (!thumbnailElement) {
        thumbnailElement = document.createElement("div");
        thumbnailElement.classList.add("drop-zone__thumb");
        dropZoneElement.appendChild(thumbnailElement);
    }

    thumbnailElement.dataset.label = file.name;

    if (file.type.startsWith("image/")) {
        const reader = new FileReader();

        reader.readAsDataURL(file);
        reader.onload = () => {
            thumbnailElement.style.backgroundImage = `url('${reader.result}')`;
        };
    } else {
        thumbnailElement.style.backgroundImage = null;
    }
}
// ↓↓↓↓↓↓↓↓ 轉成url後直接傳到資料庫
//const file = document.getElementById('drop-zone__input');
//const url = document.getElementById('url');
//file.addEventListener('change', ev => {
//    const cloudinary = require('cloudinary').v2;
//    cloudinary.config({
//        cloud_name: dz5yujoyp,
//        api_key: 899612568264711,
//        api_secret: jPdZnY_hUQlAxXkwbsfvjxOP1HM
//    });
//    const file = './../assets/images/waffle.png';
//    const options = {
//        tags: 'waffle'
//    }
//    cloudinary.uploader.upload(file, options).then(image =& gt; {
//        console.log(image);
//    }).catch(err =& gt; {
//    console.error(err);
//});
//});


// ↓↓↓↓↓↓↓↓ 轉成url後直接傳到資料庫
const file = document.getElementById('drop-zone__input');
const url = document.getElementById('url');
file.addEventListener('change', ev => {
    const formdata = new FormData()
    formdata.append('image', ev.target.files[0])
    fetch('https://api.imgur.com/3/image/', {
        method: "post",
        headers: {
            Authorization: 'Client-ID 967369ae5856c25'
        }
        , body: formdata
    })
        .then(data => data.json())
        .then(data => {
            url.innerText = data.data.link
            console.log(url.innerText)
            let result = {}
            result.Photo = data.data.link
            return fetch('/Personal/SendtoDatabase', {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(result)
            })
        })
        .then((res) => console.log(res))
});

// 編輯個人資訊 //
const about_me_input = document.querySelector('#about_me_input');
const about_me_output = document.querySelector('#about_me_output');
const location_input = document.querySelector('#location_input');
const location_output = document.querySelector('#location_output');
const language_input = document.querySelector('#language_input');
const language_output = document.querySelector('#language_output');
const cancel_btn = document.querySelector('#cancel_btn');
const save_btn = document.querySelector('#save_btn');

document.querySelector('.edit-personal-data').addEventListener("click", () => {
    document.querySelector('.edit-personal-data').disabled = true;
    about_me_input.value = about_me_output.innerText;
    location_input.value = location_output.innerText;
    language_input.value = language_output.innerText;
    cancel_btn.style.visibility = 'visible';
    save_btn.style.visibility = 'visible';
    document.querySelector('.show_personal_data').style.display = 'none';
});

save_btn.addEventListener("click", () => {
    about_me_output.innerText = about_me_input.value;
    location_output.innerText = location_input.value;
    language_output.innerText = language_input.value;

    cancel_btn.style.visibility = 'hidden';
    save_btn.style.visibility = 'hidden';
    document.querySelector('.edit-personal-data').disabled = false;
    document.querySelector('.show_personal_data').style.display = 'inline';
});

cancel_btn.addEventListener("click", () => {
    cancel_btn.style.visibility = 'hidden';
    save_btn.style.visibility = 'hidden';
    document.querySelector('.edit-personal-data').disabled = false;
    document.querySelector('.show_personal_data').style.display = 'inline';
});

// Review 切換效果
function click_tenant_review() {
    document.getElementById('landlord_review').style.borderBottomColor = "#ffffff";
    document.getElementById('tenant_review').style.borderBottom = "medium solid #222222";
}

function click_landlord_review() {
    document.getElementById('tenant_review').style.borderBottomColor = "#ffffff";
    document.getElementById('landlord_review').style.borderBottom = "medium solid #222222";
}