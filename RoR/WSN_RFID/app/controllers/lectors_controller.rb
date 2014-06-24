class LectorsController < ApplicationController
  before_action :set_lector, only: [:show, :edit, :update, :destroy]

  before_filter :authorize_lector

  # GET /lectors
  # GET /lectors.json
  def index
    @lectors = Lector.all
  end

  # GET /lectors/1
  # GET /lectors/1.json
  def show
  end

  # GET /lectors/new
  def new
    @lector = Lector.new
    @label = "Crear"
  end

  # GET /lectors/1/edit
  def edit
    @label = "Actualizar"
  end

  # POST /lectors
  # POST /lectors.json
  def create
    @lector = Lector.new(lector_params)

    respond_to do |format|
      if @lector.save
        format.html { redirect_to lectors_path, notice: 'El lector fue creado con éxito.' }
        format.json { render :show, status: :created, location: @lector }
      else
        format.html { render :new }
        format.json { render json: @lector.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /lectors/1
  # PATCH/PUT /lectors/1.json
  def update
    respond_to do |format|
      if @lector.update(lector_params)
        format.html { redirect_to lectors_path, notice: 'El lector fue actualizado.' }
        format.json { render :show, status: :ok, location: @lector }
      else
        format.html { render :edit }
        format.json { render json: @lector.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /lectors/1
  # DELETE /lectors/1.json
  def destroy
    @lector.destroy
    respond_to do |format|
      format.html { redirect_to lectors_url, notice: 'El lector fue eliminado.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_lector
      @lector = Lector.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def lector_params
      params.require(:lector).permit(:nombre, :posicion)
    end
end
