/*
	For Edit This File Please Read Documentation
*/

var myPlaylist = [
	{
		mp3:'http://songsx.pk/pk-mp3/eva-simons-hey-mr-policeman/v660012273_4343500002.mp3',
		oga:'music/5.ogg',
		title:'Policeman',
		artist:'Eva Simons ft. Konshens',
		rating:5,
		duration:'3:13',
		cover:'music/180x180.jpg'
	}
];
jQuery(document).ready(function ($) {
	$('.music-single').ttwMusicPlayer(myPlaylist, {
		tracksToShow:3,
		autoplay:true,
		ratingCallback:function(index, playlistItem, rating){
			//some logic to process the rating, perhaps through an ajax call
		},
		jPlayer:{
			swfPath:'http://www.jplayer.org/2.1.0/js'
		}
	});
});