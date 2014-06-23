require 'open-uri'
require 'json'

class VehiculosController < ApplicationController
  before_action :set_vehiculo, only: [:show, :edit, :update, :destroy]

  # GET /vehiculos
  # GET /vehiculos.json
  def index
    @vehiculos = Vehiculo.all

    if params.has_key?(:patente)
      patente = params[:patente]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:patente].matches("%#{patente}%"))
    end  

    if params.has_key?(:marca) && params[:marca] != "Seleccione..."
      marca = params[:marca]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:marca].matches("%#{marca}%"))
    end

    if params.has_key?(:modelo)
      modelo = params[:modelo]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:modelo].matches("%#{modelo}%"))
    end

    if params.has_key?(:anho) && params[:anho] != ""
      anho = params[:anho].to_i
      @vehiculos = @vehiculos.where(anho: anho)
    end
    
    if params.has_key?(:color) && params[:color] != "Seleccione..."
      color = params[:color]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:color].matches("%#{color}%"))
    end
    
    if params.has_key?(:chasis)
      chasis = params[:chasis]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:chasis].matches("%#{chasis}%"))
    end
    
    if params.has_key?(:n_motor)
      n_motor = params[:n_motor]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:n_motor].matches("%#{n_motor}%"))
    end
    
    if params.has_key?(:kilometraje) && params[:kilometraje] != ""
      kilometraje = params[:kilometraje].to_i
      @vehiculos = @vehiculos.where(kilometraje: kilometraje)
    end
    
    if params.has_key?(:tipo_combustible) && params[:tipo_combustible] != "Seleccione..."
      tipo_combustible = params[:tipo_combustible]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:tipo_combustible].matches("%#{tipo_combustible}%"))
    end
    
    if params.has_key?(:es_4x4) && params[:es_4x4] != "Seleccione..."
      es_4x4 = params[:es_4x4] == 'Tiene'
      @vehiculos = @vehiculos.where(es_4x4: es_4x4)
    end
    
    if params.has_key?(:categoria) && params[:categoria] != "Seleccione..."
      categoria = params[:categoria]
      @vehiculos = @vehiculos.where(Vehiculo.arel_table[:categoria].matches("%#{categoria}%"))
    end
    
    if params.has_key?(:n_puertas) && params[:n_puertas] != ""
      n_puertas = params[:n_puertas].to_i
      @vehiculos = @vehiculos.where(n_puertas: n_puertas)
    end
    
    if params.has_key?(:a_c) && params[:a_c] != "Seleccione..."
      a_c = params[:a_c] == 'Tiene'
      @vehiculos = @vehiculos.where(a_c: a_c)
    end
    
    if params.has_key?(:gps) && params[:gps] != "Seleccione..."
      gps = params[:gps] == 'Tiene'
      @vehiculos = @vehiculos.where(gps: gps)
    end
    
    if params.has_key?(:disponible) && params[:disponible] != "Seleccione..."
      disponible = params[:disponible] == 'Disponible'
      @vehiculos = @vehiculos.where(disponible: disponible)
    end
      
    if params.has_key?(:costo_min) && params[:costo_min] != ""
      costo_min = params[:costo_min].to_i
      if params.has_key?(:costo_max) && params[:costo_max] != ""
        costo_max = params[:costo_max].to_i
        @vehiculos = @vehiculos.where(costo: [costo_min, costo_max])
      else
        @vehiculos = @vehiculos.where(costo: costo_min)
      end
    end

  end

  # GET /vehiculos/1
  # GET /vehiculos/1.json
  def show
	#result = JSON.parse(open("https://www.googleapis.com/customsearch/v1?key=AIzaSyBFHG4xWGAsLGIFL1mqETW-x7RrkKQC2U0&cx=000280892056063219607:nyce3z7od2g&q=#{@vehiculo.marca}+#{@vehiculo.modelo}&searchType=image&fileType=jpg&imgSize=small&alt=json", {ssl_verify_mode: OpenSSL::SSL::VERIFY_NONE}).read)
	@image = ""#result["items"][0]["link"]
  end

  # GET /vehiculos/new
  def new
    @vehiculo = Vehiculo.new
    @label = "Crear"
  end

  # GET /vehiculos/1/edit
  def edit
    @label = "Actualizar"
  end

  # POST /vehiculos
  # POST /vehiculos.json
  def create
    @vehiculo = Vehiculo.new(vehiculo_params)

    respond_to do |format|
      if @vehiculo.save
        format.html { redirect_to vehiculos_path, notice: 'El vehículo fue creado con éxito.' }
        format.json { render :show, status: :created, location: @vehiculo }
      else
        format.html { render :new }
        format.json { render json: @vehiculo.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /vehiculos/1
  # PATCH/PUT /vehiculos/1.json
  def update
    respond_to do |format|
      if @vehiculo.update(vehiculo_params)
        format.html { redirect_to vehiculos_path, notice: 'Los datos del vehículo fueron actualizados.' }
        format.json { render :show, status: :ok, location: @vehiculo }
      else
        format.html { render :edit }
        format.json { render json: @vehiculo.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /vehiculos/1
  # DELETE /vehiculos/1.json
  def destroy
    @vehiculo.destroy
    respond_to do |format|
      format.html { redirect_to vehiculos_url, notice: 'El vehículo fue eliminado.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_vehiculo
      @vehiculo = Vehiculo.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def vehiculo_params
      params.require(:vehiculo).permit(:patente, :marca, :modelo, :anho, :color, :chasis, :n_motor, :kilometraje, :tipo_combustible, :es_4x4, :categoria, :n_puertas, :a_c, :gps, :disponible, :costo_min, :costo_max, :costo)
    end
end
