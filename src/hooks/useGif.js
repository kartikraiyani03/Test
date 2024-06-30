// // import React from 'react'
// // import axios from 'axios';
// // import { useEffect } from 'react';
// // import { useState } from 'react';


// // const API_KEY = process.env.REACT_APP_GIPHY_API_KEY;
// // const url = `https://api.giphy.com/v1/gifs/random?api_key=${API_KEY}`;

// // const useGif = (tag) => {
// //   const [gif, setGif] = useState('');
// //   const [loading, setLoading] = useState(false);

// //   async function fetchData(tag) {
// //     setLoading(true);
    
// //     const {data} = await axios.get(tag ? `${url}&tag=${tag}`  : url);
// //     const imageSource = data.data.images.downsized_large.url;
// //     setGif(imageSource);
// //     setLoading(false);
// //   }
  
  
// //   useEffect( () => {
// //     fetchData('car');
// //   },[] )

// //   return {gif, loading, fetchData};
// // };

// // export default useGif;

// import React from 'react'

// export const useGif = () => {
//   let API_KEY = process.env.REACT_APP_GIPHY_API_KEY 
//     let [gif,setgif] = useState('')
//     let [load,setload] = useState(false)
    
//     async function fetchdata()
//     {
//         setload(true)
//         let url =  `https://api.giphy.com/v1/gifs/random?api_key=${API_KEY}`;
//         let {data} = await axios.get(url)
//         // console.log(data)
//         let src = data.data.images.downsized_large.url
//         console.log(src)
//         setgif(src)
//         setload(false)
//     }

//     useEffect(() =>
//     {
//         fetchdata()
//     },[])


//     function ClickHandler()
//     {
//         fetchdata()
//     }


//    return (
//     <div className='random'>
        
//         <h1>Random GIF</h1>
        
//         {
//             load ? (<Spinner/>) : (<img src={gif} width={450} height={450} alt="" />
//             )
//         }

//         <button onClick={ClickHandler}>Generate</button>
//     </div>
//   )
// }

// export default useGif