// Travel Website home page
// Fictional company: Surff, Inc.
// Author: Marlon R.
// Date:  February 24, 2010 
// Pront end web development
// Final assingment 


// array containing information about the images:
// - image source
// - link to open when clicking on the image
// - description

const images = [
    {
        imgSrc: 'https://i.picsum.photos/id/409/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/argentina',
        imgDescription: 'Stroll the streets of Buenos Aires'
    },
    {
        imgSrc: 'https://i.picsum.photos/id/1018/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/new-zealand',
        imgDescription: 'See the beauty of New Zealand'
    },
    {
        imgSrc: 'https://i.picsum.photos/id/392/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/united-states',
        imgDescription: 'Enjoy the sunshine in California'
    },
    {
        imgSrc: 'https://i.picsum.photos/id/1040/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/germany',
        imgDescription: 'Visit traditional German villages'
    },
    {
        imgSrc: 'https://i.picsum.photos/id/219/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/kenya',
        imgDescription: 'Go on a safari in Kenya'
    },
    {
        imgSrc: 'https://i.picsum.photos/id/428/600/350.jpg',
        imgLink: 'https://travel.gc.ca/destinations/china',
        imgDescription: 'Taste the flavours of China'
    }
];


let content = '';

// loop through the array and use an anonymous function to put together html code
images.forEach(function(image){
    content +=  `<div class="content_img"><a href="${image.imgLink}" target="_blank"><img src="${image.imgSrc}" alt="${image.imgDescription}" ></a><div class="text1">${image.imgDescription}</div></div>`;
});

const gallery = document.querySelector('.middle-section-gallery');
// set generated html in the div element referenced by middle-section-gallery class
gallery.innerHTML = content;
