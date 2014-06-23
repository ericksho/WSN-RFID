class ArticulosController < ApplicationController
  before_action :set_articulo, only: [:show, :edit, :update, :destroy]

  # GET /articulos
  # GET /articulos.json
  def index
    @articulos = Articulo.all

    if params.has_key?(:rfid) && params[:rfid] != "Seleccione..."
      rfid = params[:rfid].to_i
      @articulos = @articulos.where(rfid: rfid)
    end
  end

  # GET /articulos/1
  # GET /articulos/1.json
  def show
    @persona = Persona.find_by_id(@articulo.persona_id)
    @vehiculo = Vehiculo.find_by_id(@articulo.vehiculo_id)
  end

  # GET /articulos/new
  def new
    @articulo = Articulo.new
    @label = "Crear"
  end

  # GET /articulos/1/edit
  def edit
    @persona_selected = @articulo.persona_id
    @vehiculo_selected = @articulo.vehiculo_id
    @label = "Actualizar"
  end

  # POST /articulos
  # POST /articulos.json
  def create
    @articulo = Articulo.new(articulo_params)

    respond_to do |format|
      if @articulo.save
        format.html { redirect_to articulos_path, notice: 'El artículo fue creado con éxito.' }
        format.json { render :show, status: :created, location: @articulo }
      else
        format.html { render :new }
        format.json { render json: @articulo.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /articulos/1
  # PATCH/PUT /articulos/1.json
  def update
    respond_to do |format|
      if @articulo.update(articulo_params)
        format.html { redirect_to articulos_path, notice: 'El articulo fue actualizado.' }
        format.json { render :show, status: :ok, location: @articulo }
      else
        format.html { render :edit }
        format.json { render json: @articulo.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /articulos/1
  # DELETE /articulos/1.json
  def destroy
    @articulo.destroy
    respond_to do |format|
      format.html { redirect_to articulos_url, notice: 'El articulo fue eliminado.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_articulo
      @articulo = Articulo.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def articulo_params
      params.require(:articulo).permit(:rfid, :estado,:vehiculo_id,:persona_id, :upr)
    end
end
